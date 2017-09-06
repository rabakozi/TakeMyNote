using System.ServiceModel;

namespace TakeMyNote.WcfService
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        double Add(double dblNum1, double dblNum2);[OperationContract]
        double Subtract(double dblNum1, double dblNum2);[OperationContract]
        double Multiply(double dblNum1, double dblNum2);[OperationContract]
        double Divide(double dblNum1, double dblNum2);
    }
}       
