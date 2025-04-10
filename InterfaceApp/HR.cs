namespace HR
{
    public interface IPerson
    {
        System.DateTime DateOfBirth { set; get; }
        int GetAge();
    }
    public interface IEmployee
    {
        string GetHealthInsuranceAmount(); // bydefault is it public and abstract
        // auto-properties
        int EmpId { set; get; }
        string EmpName { set; get; }
        string Location { set; get; }

    }
    public class Manager : IEmployee, IPerson
    {
        private int _empId;
        private string _empName;
        private string _location;
        private string _departmentName;
        private System.DateTime _dateOfBirth;

        public System.DateTime DateOfBirth
        {
            set
            {
                _dateOfBirth = value;
            }
            get
            {
                return _dateOfBirth;
            }
        }
        public int EmpId
        {
            set
            {
                if (value >= 1000 && value <= 2000)
                {
                    _empId = value;
                }
            }
            get
            {
                return _empId;
            }
        }

        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }

        public string Location
        {
            set
            {
                _location = value;
            }
            get
            {
                return _location;
            }
        }

        public string DepartmentName
        {
            set
            {
                _departmentName = value;
            }
            get
            {
                return _departmentName;
            }
        }
        public Manager(int id, string name, string location, string deptName)
        {
            this._empId = id;
            this._empName = name;
            this._location = location;
            this._departmentName = deptName;
        }
        public string GetHealthInsuranceAmount()
        {
            return "Additional health insurance amount is: 1000";
        }

        public int GetAge()
        {
            int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
            return a;
        }


    }
    public class SalesMan : IEmployee
    {
        private int _empId;
        private string _empName;
        private string _location;
        private string _departmentName;
        public int EmpId
        {
            set
            {
                if (value >= 500 && value < 1000)
                {
                    _empId = value;
                }
            }
            get
            {
                return _empId;
            }
        }

        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }

        public string Location
        {
            set
            {
                _location = value;
            }
            get
            {
                return _location;
            }
        }

        public string DepartmentName
        {
            set
            {
                _departmentName = value;
            }
            get
            {
                return _departmentName;
            }
        }
        public SalesMan(int id, string name, string location, string deptName)
        {
            this._empId = id;
            this._empName = name;
            this._location = location;
            this._departmentName = deptName;
        }
        public string GetHealthInsuranceAmount()
        {
            return "Additional health insurance amount is: 500";
        }


    }
}
