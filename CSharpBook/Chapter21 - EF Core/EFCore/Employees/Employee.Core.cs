namespace Employees;

internal partial class Employee

{

    private string _empName;
    private int _empId;
    private float _currPay;
    private int _empAge;
    private string _empSSN;
    private EmployeePayTypeEnum _payType;
    private DateTime _hireDate;
    protected BenefitPackage EmpBenefits = new BenefitPackage();

    public BenefitPackage Benefits { get=>EmpBenefits; set=>EmpBenefits=value; }

    public DateTime HireDate { get => _hireDate; set => _hireDate = value; }

    public int Id { get { return _empId; } set { _empId = value; } }
    public string Name
    {
        get { return _empName; }
        set { _empName = value; }

    }
    public int Age { get { return _empAge; } set { _empAge = value; } }
    public float Pay { get { return _currPay; } set { _currPay = value; } }
    public string SSN { get => _empSSN; private set => _empSSN = value; }
    public EmployeePayTypeEnum PayType
    {
        get { return _payType; }
        set { _payType = value; }
    }
    public class BenefitPackage
    {
        public enum BenefitPackageLevel
        {
            Standard, Gold, Platinum
        }
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }


}