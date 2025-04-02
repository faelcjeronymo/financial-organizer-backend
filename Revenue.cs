public class Revenue
{
	public string Description { get; set; }
	public decimal Value { get; set; }
	public bool Received { get; set; }
	public string AditionalInfo { get; set; }
	public DateTime CreatedAt { get; set; }
	public TransactionCategory TransactionCategory { get; set; }
}