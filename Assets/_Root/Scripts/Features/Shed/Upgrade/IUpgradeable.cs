namespace _Root.Scripts.Features.Shed.Upgrade
{
    internal interface IUpgradable
    {
        float Speed { get; set; }
        void Restore();
    }
}
