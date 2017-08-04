using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Data;


namespace SystemCustomers.ManageProjectToCustomers
{
    class ManageViewingProjectToCompany
    {
        public DataTable InitializeListProjectCompany()
        {
            using (var ds = new DataSet())
            {
                using (var myClient = new SRProjectCompanies.ProjectCompaniesServicesClient())
                {
                    myClient.Open();
                    string stringValue = myClient.GetAllProjectToCompany();
                    StringReader reader = new StringReader(stringValue);
                    ds.ReadXml(reader);
                    myClient.Close();
                }  
                return ds.Tables["ProjectCompanies"];
            }

          //  return ProjectCompaniesServices.Instance.GetAllProjectToCompany();
        }

        //public List<dynamic> InitializeListProjectCompany()
        //{

        //    return ProjectCompaniesServices.Instance.GetAllProjectToCompany();
        //}


 /*       private string SaveAttachment(byte[] objData, string strFileToSave)
        {     var objSfd = new SaveFileDialog();
              objSfd.FileName = strFileToSave;
              string[] getfiledate = strFileToSave.Split(new[] { '.' });
              string fileType = getfiledate[1];
         
              switch (fileType)
              {
                  case "docx":
                      objSfd.Filter = string.Format("Word Doc (*.{0})|*.{0}", fileType);
                      break;
                  case "doc":
                      objSfd.Filter = string.Format("Word Doc (*.{0})|*.{0}", fileType);
                      break;
                  case "mp3":
                      objSfd.Filter = string.Format("MP3 (*.{0})|*.{0}", fileType);
                      break;
                  case "pdf":
                      objSfd.Filter = string.Format("PDF (*.{0})|*.{0}", fileType);
                      break;
              }

              if (objSfd.ShowDialog() != DialogResult.Cancel)
              {
                 string  strFileToSave1 = objSfd.FileName;
                  var objFileStream = new FileStream(strFileToSave1, FileMode.Create, FileAccess.Write);
                  objFileStream.Write(objData, 0, objData.Length);
                  objFileStream.Close();
                  return strFileToSave1;
              }
            return null;
        }*/

        public List<string> GetDestination()
        {
            using (var myprojectCompanies = new SRProjectCompanies.ProjectCompaniesServicesClient())
            {
                var list = new List<string>();
                string[] str = myprojectCompanies.GetDestination();
                list = str.ToList();
                return list;
            }
        }

        public DialogResult EditProjectCompany(DataGridViewRow dr)
        {
           
            var companyId = dr.Cells["idCompany"].Value.ToString();
            var projectId = dr.Cells["ProjectId"].Value.ToString();
            var destination = dr.Cells["destination"].Value.ToString();
            var companyName = dr.Cells["NameCompany"].Value.ToString();
            var projectName = dr.Cells["NameProject"].Value.ToString();
            var priceType = dr.Cells["priceType"].Value.ToString();
            var discription = dr.Cells["Discription"].Value.ToString();
            var paid = dr.Cells["paid"].Value.ToString();
            using (
                var editData = new AddProjectCustomers(companyName, projectName, companyId, projectId,
                                                       priceType,
                                                       discription,
                                                       paid,
                                                       destination,
                                                       DateTime.Parse(dr.Cells["DateStartProject"].Value.ToString()),
                                                       DateTime.Parse(dr.Cells["DateFinishProject"].Value.ToString())))
            {
                editData.btnAdd.Visible = false;
                return editData.ShowDialog();
            }
        }

        public void DeleteProjectCompany(DataGridViewRow dr)
        {
            using (var myClient = new SRProjectCompanies.ProjectCompaniesServicesClient())
            {
                var projectCompany = new SRProjectCompanies.ProjectCompanies();
                projectCompany.IdCompany = Convert.ToInt16(dr.Cells["idCompany"].Value.ToString());
                projectCompany.IdProject = Convert.ToInt16(dr.Cells["ProjectId"].Value.ToString());
                myClient.Delete(projectCompany);
            }

           // ProjectCompaniesServices.Instance.DeleteProjectToCompany(projectId, companyId);
        }
    }
}
