using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetDal;
using ADTO;

namespace ABAL
{
    public class ProjectXEFBAL
    {
        ProjectXEFDAL obj;
        public ProjectXEFBAL()
        {
            obj = new ProjectXEFDAL();

        }
        public List<FacultyDTO> GetFaculties()
        {
            var facList = obj.GetFaculties();
            return facList;
        }
        public int AddNewFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.AddNewFaculty(newFacDetails);
            return returnvalue;
        }
        public int UpdateFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.UpdateFaculty(newFacDetails);
            return returnvalue;
        }
        public int DeleteFaculty(FacultyDTO FacID)
        {
            int returnvalue = obj.DeleteFaculty(FacID);
            return returnvalue;
        }
    }
}