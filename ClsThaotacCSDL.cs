using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Doan1
{
    internal class ClsThaotacCSDL
    {
        // Connection string - ĐÃ SỬA ĐÚNG TÊN DATABASE
        private readonly string strConnect =
            "Server=localhost;Initial Catalog=QLsinhvienKTX;Integrated Security=True;TrustServerCertificate=True;";
        // ==================== 1. HÀM LẤY DỮ LIỆU (SELECT) ====================

        /// <summary>
        /// Thực thi câu lệnh SELECT, trả về DataTable
        /// </summary>
        /// <param name="sql">Câu lệnh SQL SELECT</param>
        /// <returns>DataTable chứa kết quả</returns>
        public DataTable ThucThiSQL(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối: " + ex.Message);
            }

            return dt;
        }

        // ==================== 2. HÀM INSERT, UPDATE, DELETE ====================

        /// <summary>
        /// Thực thi câu lệnh INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="sql">Câu lệnh SQL (INSERT/UPDATE/DELETE)</param>
        /// <param name="parameters">Danh sách tham số (có thể null)</param>
        /// <returns>Số dòng bị ảnh hưởng</returns>
        public int ThucThiNonQuery(string sql, List<SqlParameter> parameters = null)
        {
            int result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối: " + ex.Message);
            }

            return result;
        }

        // ==================== 3. HÀM SELECT CÓ THAM SỐ ====================

        /// <summary>
        /// Thực thi câu lệnh SELECT có tham số, trả về DataTable
        /// </summary>
        /// <param name="sql">Câu lệnh SQL SELECT</param>
        /// <param name="parameters">Danh sách tham số</param>
        /// <returns>DataTable chứa kết quả</returns>
        public DataTable ThucThiSQL(string sql, List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối: " + ex.Message);
            }

            return dt;
        }

        // ==================== 4. HÀM KIỂM TRA KẾT NỐI ====================

        /// <summary>
        /// Kiểm tra kết nối đến database
        /// </summary>
        /// <returns>True nếu kết nối thành công, False nếu thất bại</returns>
        public bool KiemTraKetNoi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // ==================== 5. HÀM LẤY GIÁ TRỊ ĐẦU TIÊN (SELECT COUNT, SUM, MAX...) ====================

        /// <summary>
        /// Thực thi câu lệnh SELECT trả về 1 giá trị duy nhất (COUNT, SUM, MAX, MIN...)
        /// </summary>
        /// <param name="sql">Câu lệnh SQL</param>
        /// <returns>Giá trị đầu tiên của cột đầu tiên</returns>
        public object ThucThiScalar(string sql)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}