using System.Windows.Forms;
using SystemCustomers.MessageUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.ServiceModel;

namespace SystemCustomers.ManageProject
{
    class ManageViewingAllProject
    {
        public static string Id { get; set; }

        public DataTable InitializeProject()
        {
            using (var ds = new DataSet())
            {
                using (var myClient = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    try
                    {
                        var project = new ServiceManager.Project();
                       // project.Method = "GetAllProjects";
                        project.Method = "GetAllProjectsDataSet";
                        project = myClient.ManageProject(project);
                       // string stringValue = project.DataProject;
                       // StringReader reader = new StringReader(stringValue);
                       // ds.ReadXml(reader);
                       // return ds.Tables["Project"];
                        return project.DataProjectDataSet.Tables[0];
                    }
                    catch (FaultException ex)
                    {
                        LogUtils.WriteToLog(string.Format(" Error Viewing Project. Exception: {0} " ,ex.Message));
                        LogUtils.SystemEventLogsError(string.Format(" Error Viewing Project. Exception: {0} ", ex.Message));
                        return null;
                    }
                }
            }
        }

        public DialogResult EditProject(DataGridViewRow dr)
        {
            using (var project = new AddProject(dr.Cells["projectName"].Value.ToString(), dr.Cells["projectDescription"].Value.ToString(), Convert.ToInt16(dr.Cells["IdProject"].Value)))
            {
                // int id = Convert.ToInt16(dr.Cells["IdProject"].Value);
                project.btnAdd.Visible = false;
                var result = project.ShowDialog();
                if (result == DialogResult.Cancel) return result;
                else
                {
                    LogUtils.WriteToLog(" Edit Row Viewing All Project: " + dr.Cells["projectName"].Value.ToString());
                    LogUtils.SystemEventLogsInformation(" Edit Row Viewing All Project: " + dr.Cells["projectName"].Value.ToString());
                    return result;
                }
            }
        }

        public void DeleteProject(DataGridViewRow dr)
        {
            Id = dr.Cells["idProject"].Value.ToString();
            using (var myClient = new ServiceManager.ServiceSystemCompaniesClient())
            {
                try
                {
                    var project = new ServiceManager.Project();
                    project.idProject = Convert.ToInt32(Id);
                    project.Method = "Delete";
                    myClient.ManageProject(project);
                    LogUtils.WriteToLog(" Delete Row Viewing All Project: " + dr.Cells["projectName"].Value.ToString());
                    LogUtils.SystemEventLogsInformation(" Delete Row Viewing All Project: " + dr.Cells["projectName"].Value.ToString());
                }
                catch (FaultException ex)
                {
                    LogUtils.WriteToLog(string.Format(" Faild Delete Project: {0}. Exception: {1} ", dr.Cells["projectName"].Value.ToString(), ex.Message));
                    LogUtils.SystemEventLogsError(string.Format(" Faild Delete Project: {0}. Exception: {1} ", dr.Cells["projectName"].Value.ToString(), ex.Message));
                }
            }
        }
    }
}
