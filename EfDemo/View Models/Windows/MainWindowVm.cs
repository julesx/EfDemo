using System.Collections.ObjectModel;
using EfDemo.View_Models.Items;
using EfDemo.Classes;
using EfDemo.Models.Items;
using EfDemo.View_Models.Tabs;

namespace EfDemo.View_Models.Windows
{
    public class MainWindowVm
    {
        #region Tab View Models

        public CoursesVm CoursesVm { get; set; }
        public DepartmentsVm DepartmentsVm { get; set; }
        public DistrictsVm DistrictsVm { get; set; }
        public SchoolsVm SchoolsVm { get; set; }
        public StudentsVm StudentsVm { get; set; }
        public TeachersVm TeachersVm { get; set; }

        #endregion

        #region C'Tor

        public MainWindowVm()
        {
            InitTabVms();
        }

        #endregion

        #region Private Methods     

        private void InitTabVms()
        {
            CoursesVm = new CoursesVm();
            DepartmentsVm = new DepartmentsVm();
            DistrictsVm = new DistrictsVm();
            SchoolsVm = new SchoolsVm();
            StudentsVm = new StudentsVm();
            TeachersVm = new TeachersVm();
        }

        #endregion
    }
}
