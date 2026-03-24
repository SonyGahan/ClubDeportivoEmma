using System;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Utils
{
    public class ValidadorNegocio
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        // REGLA 1: Validación de Apto Médico (Para Socios y No Socios)
        public bool ValidarAptoMedico(int idPersona, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT apto_medico, fecha_venc_apto FROM persona WHERE id_persona = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPersona);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool tieneApto = Convert.ToBoolean(reader["apto_medico"]);

                                if (!tieneApto)
                                {
                                    mensaje = "El cliente no ha presentado el Apto Médico.";
                                    return false;
                                }

                                if (reader["fecha_venc_apto"] == DBNull.Value)
                                {
                                    mensaje = "No hay fecha de vencimiento registrada para el Apto.";
                                    return false;
                                }

                                DateTime vencimiento = Convert.ToDateTime(reader["fecha_venc_apto"]);
                                if (vencimiento < DateTime.Today)
                                {
                                    mensaje = "El Apto Médico está vencido desde el " + vencimiento.ToString("dd/MM/yyyy");
                                    return false;
                                }

                                return true; // Todo ok
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { mensaje = "Error en validación: " + ex.Message; }
            return false;
        }

        // REGLA 2: Validación de Morosidad (Solo para Socios)
        public bool EsSocioMoroso(int idSocio, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Buscamos si tiene al menos una cuota vencida
                    string sql = "SELECT COUNT(*) FROM cuota WHERE id_socio = @id AND estado_pago = 'Vencido'";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idSocio);
                        int cantidadVencidas = Convert.ToInt32(cmd.ExecuteScalar());

                        if (cantidadVencidas > 0)
                        {
                            mensaje = "El socio posee " + cantidadVencidas + " cuota(s) vencida(s). Debe regularizar su situación.";
                            return true; // Es moroso
                        }
                    }
                }
            }
            catch (Exception ex) { mensaje = "Error al consultar deuda: " + ex.Message; }
            return false; // No es moroso
        }
    }
}