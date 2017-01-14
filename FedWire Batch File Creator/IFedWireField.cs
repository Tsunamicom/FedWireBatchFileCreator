namespace FedWire_Batch_File_Creator
{
    public interface IFedWireField
    {
        string FieldValue { get; set; }
        string Tag { get; }
    }
}