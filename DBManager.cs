using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExercise
{
    public static class DBManager
    {
        private static SqlConnection conn;
        private static SqlCommand cmd;

        public static void ConnectToDatabase()
        {
            try
            {
                conn = new SqlConnection();
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnData"].ConnectionString;
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnDataLocal"].ConnectionString;
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;

            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen csatlakozás", ex);
            }
        }

        public static void DisconnectFromDataBase()
        {
            try
            {
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen lecsatlakozás", ex);
            }
        }

        public static List<Jarmu> JarmuvekKiolvasasa()
        {
            try
            {
                List<Jarmu> jarmuvek = new List<Jarmu>();
                //AUTO-k kilistázása
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM [JARMU] INNER JOIN [AUTO] ON [JARMU].[RENDSZAM] = [AUTO].[RENDSZAM]";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jarmuvek.Add(new Auto(
                            (AutoTipus)(int)reader["AUTOTIPUS"],
                            Convert.ToInt32(reader["CSOMAGTERTERFOGAT"]),
                            reader["RENDSZAM"].ToString(),
                            reader["GYARTO"].ToString(),
                            reader["TIPUS"].ToString(),
                            Convert.ToInt32(reader["HENGERURTARTALOM"]))
                            );
                    }

                    reader.Close();
                }

                //MOTOR-ok kilistázása
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM [JARMU] INNER JOIN [MOTOR] ON [JARMU].[RENDSZAM] = [MOTOR].[RENDSZAM]";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jarmuvek.Add(new Motor((MotorTipus)(int)reader["MOTORTIPUS"],
                            reader["RENDSZAM"].ToString(),
                            reader["GYARTO"].ToString(),
                            reader["TIPUS"].ToString(),
                             Convert.ToInt32(reader["HENGERURTARTALOM"]))
                            );
                    }

                    reader.Close();
                }

                return jarmuvek;
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen kilistázás", ex);
            }
        }

        public static void AutoFelvitele(Auto auto)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [JARMU] VALUES (@r, @gy, @t, @h)";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);
                cmd.Parameters.AddWithValue("@gy", auto.Gyarto);
                cmd.Parameters.AddWithValue("@t", auto.Tipus);
                cmd.Parameters.AddWithValue("@h", auto.Hengerurtartalom);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [AUTO] VALUES (@r, @t, @cs)";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);
                cmd.Parameters.AddWithValue("@t", (int)auto.AutoTipus);
                cmd.Parameters.AddWithValue("@cs", auto.CsomagterTerfogat);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen AUTO felvitel", ex);
            }
        }

        public static void MotorFelvitele(Motor motor)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [JARMU] VALUES (@r, @gy, @t, @h)";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);
                cmd.Parameters.AddWithValue("@gy", motor.Gyarto);
                cmd.Parameters.AddWithValue("@t", motor.Tipus);
                cmd.Parameters.AddWithValue("@h", motor.Hengerurtartalom);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [MOTOR] VALUES (@r, @t, @j)";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);
                cmd.Parameters.AddWithValue("@t", (int)motor.MotorTipus);
                cmd.Parameters.AddWithValue("@j", motor.Jogositvany);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen MOTOR felvitel", ex);
            }
        }

        public static void AutoTorles(Auto auto)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [AUTO] WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [JARMU] WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen AUTO törlés", ex);
            }
        }

        public static void MotorTorles(Motor motor)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [MOTOR] WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [JARMU] WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen AUTO törlés", ex);
            }
        }

        public static void AutoModositas(Auto auto)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [AUTO] SET [CSOMAGTERTERFOGAT]=@cs WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);
                cmd.Parameters.AddWithValue("@cs", auto.CsomagterTerfogat);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [JARMU] SET [GYARTO]=@gy, [TIPUS]=@t, [HENGERURTARTALOM]=@h WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", auto.Rendszam);
                cmd.Parameters.AddWithValue("@gy", auto.Gyarto);
                cmd.Parameters.AddWithValue("@t", auto.Tipus);
                cmd.Parameters.AddWithValue("@h", auto.Hengerurtartalom);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen AUTO módosítás!", ex);
            }
        }

        public static void MotorModositas(Motor motor)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [MOTOR] SET [JOGOSITVANY]=@j WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);
                cmd.Parameters.AddWithValue("@j", motor.Jogositvany);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [JARMU] SET [GYARTO]=@gy, [TIPUS]=@t, [HENGERURTARTALOM]=@h WHERE [RENDSZAM]=@r";
                cmd.Parameters.AddWithValue("@r", motor.Rendszam);
                cmd.Parameters.AddWithValue("@gy", motor.Gyarto);
                cmd.Parameters.AddWithValue("@t", motor.Tipus);
                cmd.Parameters.AddWithValue("@h", motor.Hengerurtartalom);

                cmd.ExecuteNonQuery();
             }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen AUTO módosítás!", ex);
            }
        }

        public static void ABUrites()
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [MOTOR]";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [AUTO]";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [JARMU]";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBError("Sikertelen urites!", ex);
            }
        }
    }
}
