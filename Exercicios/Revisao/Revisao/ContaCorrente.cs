using Revisao;

internal class ContaCorrente
{
	private string numeroConta;

	private int numeroAgencia;

	public Cliente Titular { get; set; }

	public int NumeroAgencia
	{
		get { return numeroAgencia; }
		set { numeroAgencia = value; }
	}

	public string NumeroConta
	{
		get { return numeroConta; }
		set { numeroConta = value; }
	}

	public ContaCorrente(int numeroAgencia, string numeroConta)
    {
		this.numeroAgencia = numeroAgencia;
		this.numeroConta = numeroConta;
    }

    public override string ToString()
    {
		//;
		return $"Conta: {NumeroConta}, Agencia: {numeroAgencia}";
    }
}