using System;

namespace Test
{
    [TestFixture]
    public class BebidaTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            int nivel = 1;

            Bebida bebida = new Bebida(nivel);

            Assert.AreEqual(nivel, bebida.Nivel);
            Assert.AreEqual(10 - nivel, bebida.TiempoParaGenerar);
            Assert.AreEqual(nivel * 2, bebida.ValorMoneda);
        }
        [Test]
        public void CombinarCon_SameLevelBebidas_CreatesNewBebida()
        {
            Bebida bebida1 = new Bebida(1);
            Bebida bebida2 = new Bebida(1);

            Bebida nuevaBebida = bebida1.CombinarCon(bebida2);

            Assert.IsNotNull(nuevaBebida);
            Assert.AreEqual(2, nuevaBebida.Nivel);
        }

        [Test]
        public void CombinarCon_DifferentLevelBebidas_ReturnsNull()
        {
            Bebida bebida1 = new Bebida(1);
            Bebida bebida2 = new Bebida(2);

            Bebida nuevaBebida = bebida1.CombinarCon(bebida2);

            Assert.IsNull(nuevaBebida);
        }

    }

    [TestFixture]
    public class JugadorTests
    {
        [Test]
        public void GanarMonedasPorNivelBebida_GainCoinsForSpecificLevel_ReturnsCorrectCoins()
        {
            Jugador jugador = new Jugador();
            jugador.MultiplicadorDinero = 2; // Multiplicador de dinero configurado en 2

            // Simular que una bebida alcanza el nivel 3
            jugador.GanarMonedasPorNivelBebida(3);

            Assert.AreEqual(6, jugador.Monedas); // 3 (nivel de bebida) * 2 (multiplicador de dinero) = 6 monedas ganadas
        }

        [Test]
        public void GenerarBebida_GeneratesNewBebida_AddsToInventory()
        {
            Jugador jugador = new Jugador();

            // Asegurarse de que el inventario esté vacío al principio
            Assert.IsEmpty(jugador.InventarioBebidas);

            // Generar una bebida
            jugador.GenerarBebida();

            // Verificar que la bebida se agregó al inventario
            Assert.IsNotEmpty(jugador.InventarioBebidas);
        }
    }

    [TestFixture]
    public class TiendaTests
    {
        [Test]
        public void AgregarMejora_AddsMejoraToAvailableUpgrades()
        {
            Tienda tienda = new Tienda();
            Mejora nuevaMejora = new Mejora("VelocidadGeneracion", 1, 50);

            tienda.AgregarMejora(nuevaMejora);

            CollectionAssert.Contains(tienda.ObtenerMejorasDisponibles(), nuevaMejora);
        }

        [Test]
        public void ObtenerMejoraPorTipo_ExistingUpgradeType_ReturnsMejora()
        {
            Tienda tienda = new Tienda();

            Mejora mejora = tienda.ObtenerMejoraPorTipo("TiempoGeneracion");

            Assert.IsNotNull(mejora);
            Assert.AreEqual("TiempoGeneracion", mejora.Tipo);
        }

        [Test]
        public void ObtenerMejoraPorTipo_NonExistingUpgradeType_ReturnsNull()
        {
            Tienda tienda = new Tienda();

            Mejora mejora = tienda.ObtenerMejoraPorTipo("MejoraDesconocida");

            Assert.IsNull(mejora);
        }

        [Test]
        public void ComprarMejora_PlayerHasEnoughCoins_ReturnsTrue()
        {
            Tienda tienda = new Tienda();
            Jugador jugador = new Jugador();
            jugador.Monedas = 200; // Suficientes monedas para comprar la mejora
            Mejora mejora = new Mejora("TiempoGeneracion", 1, 100);

            bool compraExitosa = tienda.ComprarMejora(jugador, mejora);

            Assert.IsTrue(compraExitosa);
            Assert.AreEqual(100, jugador.Monedas); // Verificar que las monedas se dedujeron correctamente
        }

        [Test]
        public void ComprarMejora_PlayerHasNotEnoughCoins_ReturnsFalse()
        {
            Tienda tienda = new Tienda();
            Jugador jugador = new Jugador();
            jugador.Monedas = 50; // No suficientes monedas para comprar la mejora
            Mejora mejora = new Mejora("TiempoGeneracion", 1, 100);

            bool compraExitosa = tienda.ComprarMejora(jugador, mejora);

            Assert.IsFalse(compraExitosa);
            Assert.AreEqual(50, jugador.Monedas); // Verificar que las monedas no se dedujeron
        }
    }

    [TestFixture]
    public class MejoraTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            string tipo = "TiempoGeneracion";
            int nivel = 1;
            int precio = 100;

            Mejora mejora = new Mejora(tipo, nivel, precio);

            Assert.AreEqual(tipo, mejora.Tipo);
            Assert.AreEqual(nivel, mejora.Nivel);
            Assert.AreEqual(precio, mejora.Precio);
        }

    }
}