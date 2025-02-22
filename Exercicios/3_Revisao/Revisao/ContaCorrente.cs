﻿using Revisao;

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
		//
		return $"Conta: {this.NumeroConta}, Agencia: {this.numeroAgencia}";
    }

    // quando eu implemento o Equals, eu preciso implementar o GetHashCode();
    public override bool Equals(object? obj)
    {
        ContaCorrente outra = obj as ContaCorrente;

        if (outra == null) return false;

        return this.NumeroConta.Equals(outra.NumeroConta);

    }


    public override int GetHashCode()
    {
        return this.NumeroConta.GetHashCode();
    }
}