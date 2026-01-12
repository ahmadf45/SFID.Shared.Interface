namespace SFID.Shared.Interface;

public interface ILeasingShared
{
    Task UpdateDuplicateLead(int orderId);
}