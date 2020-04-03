using System.Diagnostics;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Quartz;
using System.Data;
using System.Data.SqlClient;
namespace COMP4911WebAPI.Jobs
{
    public class ReportJob : Quartz.IJob
    {

        public async Task Execute(Quartz.IJobExecutionContext context)
        {

            try
            {
                JobDataMap dataMap = context.JobDetail.JobDataMap;

                string connectionString = (string)dataMap["connectionstring"];

                using (var conn = new SqlConnection(connectionString))
                using (var Command = new SqlCommand("GenerateProjectReport", conn)
                { CommandType = CommandType.StoredProcedure })
                {
                    conn.Open();
                    Command.ExecuteNonQuery();
                    conn.Close();
                    await Task.CompletedTask;
                }

            }catch(SqlException e){
                    Debug.WriteLine("SQL execution exception in ReportJob, see stacktrace: \n"+e.StackTrace);
                    await Task.CompletedTask;
            }
            

        }
    }



}


