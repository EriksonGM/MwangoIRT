namespace UI
{
    public static class Helpers
    {
        public static string ToKwanza(this double valor)
        {
            return valor == 0 ? "0.00 kz" :  valor.ToString("### ### ###.00 'kz'");
        }

        public static double ToNegative(this double valor)
        {
            return valor < 0 ? valor : valor * -1;
        }
    }
}