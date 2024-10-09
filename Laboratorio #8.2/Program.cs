    public class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            this.idCuenta = prmtIdCuenta;
            System.Console.WriteLine(
            "Constructor Clase Base para Cuenta{0}", prmtIdCuenta);
        }

        public virtual void CalcularIntereses()
        {
            System.Console.WriteLine(
            "Cuenta.CalcularIntereses() efectuado para la cuenta{0}",
            this.idCuenta);
        }

        public string getIDCuenta()
        {
            return this.idCuenta;
        }
    }

    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente (string prmtIdCuenta): base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIDCuenta());
        }
    }

    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }
        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
            "CuentaAhorro.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIDCuenta());
        }
    }
internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";

        Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
        CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}