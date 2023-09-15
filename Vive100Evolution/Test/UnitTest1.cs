using System;

namespace Test
{
    [TestFixture]
    public class BebidaTests
    {
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
        public void ComprarMejora_PlayerHasEnoughCoins_ReturnsTrue()
        {
            Jugador jugador = new Jugador();
            jugador.Monedas = 200; // Suficientes monedas para comprar la mejora

            bool compraExitosa = jugador.ComprarMejora("TiempoGeneracion");

            Assert.IsTrue(compraExitosa);
        }

        [Test]
        public void ComprarMejora_PlayerHasNotEnoughCoins_ReturnsFalse()
        {
            Jugador jugador = new Jugador();
            jugador.Monedas = 50; // No suficientes monedas para comprar la mejora

            bool compraExitosa = jugador.ComprarMejora("TiempoGeneracion");

            Assert.IsFalse(compraExitosa);
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