namespace Calculadora_Propinas.Models
{
    public class ConsumoCompartido
    {
        public decimal ImporteDelConsumo { get; set; } = decimal.Zero;
        public int NumerosDePersonas { get; set; } = 1;
        public decimal PorcentajeDePropina { get; set; } = 10m;

        public ConsumoCompartido(
            decimal importeDelConsumo,
            int numeroDePersonas = 1,
            decimal porcentajeDePropina = 10m)
        {
            ImporteDelConsumo = importeDelConsumo;
            NumerosDePersonas = numeroDePersonas;
            PorcentajeDePropina = porcentajeDePropina;
        }

        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumerosDePersonas;
        public decimal ImporteDeLaPropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m;
        public decimal ImporteDeLaPropinaPorPersona => ImporteDelConsumo / NumerosDePersonas;
        public decimal ImporteDelConsumoConPropina => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteDelConsumoConPropinaPorPersona => ImporteDelConsumoConPropina / NumerosDePersonas;
    }
}
