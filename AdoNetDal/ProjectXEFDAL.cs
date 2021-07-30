using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADTO;
namespace AdoNetDal
{
    public class ProjectXEFDAL
    {
        public ProjectXEFDAL()
        {

        }
        public List<FacultyDTO> GetFaculties()
        {
            try
            {
                List<FacultyDTO> lstFaculty = new List<FacultyDTO>();
                DataEntity objContext = new DataEntity();
                var facDALListObj = objContext.Faculties.ToList();
                foreach (var item in facDALListObj)
                {
                    lstFaculty.Add(
                        new FacultyDTO
                        {
                            PSNo = item.PSNo,
                            EmailId = item.EmailId,
                            NAME = item.NAME

                        });
                }
                return lstFaculty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                throw ex;
            }
        }
        public int AddNewFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new DataEntity())
                {
                    Faculty facDALObj = new Faculty();
                    facDALObj.PSNo = newFacObj.PSNo;
                    facDALObj.EmailId = newFacObj.EmailId;
                    facDALObj.NAME = newFacObj.NAME;
                    objContext.Faculties.Add(facDALObj);
                    ret = objContext.SaveChanges();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                throw ex;
            }
        }
        public int UpdateFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new DataEntity())
                {
                    Faculty facDALObj = objContext.Faculties.Find(newFacObj.PSNo);

                    objContext.Faculties.Attach(facDALObj);
                    facDALObj.NAME = newFacObj.NAME;
                    ret = objContext.SaveChanges();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Ooopppss, Something went Wrong!");
                return 0;
            }
        }
        public int DeleteFaculty(FacultyDTO FacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new DataEntity())
                {
                    Faculty facDALObj = objContext.Faculties.Find(FacObj.PSNo);
                    facDALObj.PSNo = FacObj.PSNo;
                    objContext.Faculties.Remove(facDALObj);
                    ret = objContext.SaveChanges();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopppss, Something went Wrong!");
                return 0;
            }
        }
    }
}