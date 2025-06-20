using WinFormsApp1.Controllers;

namespace TestProject1
{
    [TestClass]
    public class SoalControllerTests
    {
        [TestMethod]
        public void TestGetDaftarSoal()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual);
            
            var daftar = controller.GetDaftarSoal();
            
            Assert.IsNotNull(daftar);
        }

        [TestMethod]
        public void GetDaftarSoal_ShouldReturnEmptyList_WhenNoData()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);

            var daftar = controller.GetDaftarSoal();

            Assert.IsNotNull(daftar);
            Assert.AreEqual(0, daftar.Count);
        }

        [TestMethod]
        public void TambahSoalManual_ValidJawaban_ReturnsTrue()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);
            var opsi = new List<string> { "A", "B", "C", "D" };
            string jawaban = "C";

            bool result = controller.TambahSoalManual("Apa warna bendera?", opsi, jawaban);

            Assert.IsTrue(result);
            var daftar = controller.GetDaftarSoal();
            Assert.AreEqual(1, daftar.Count);
            Assert.AreEqual("Apa warna bendera?", daftar[0].pertanyaan);
        }

        [TestMethod]
        public void TambahSoalManual_InvalidJawaban_ReturnsFalse()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);
            var opsi = new List<string> { "A", "B", "C", "D" };
            string jawaban = "X";

            bool result = controller.TambahSoalManual("Apa warna matahari?", opsi, jawaban);

            Assert.IsFalse(result);
            Assert.AreEqual(0, controller.GetDaftarSoal().Count);
        }

        [TestMethod]
        public void EditSoalManual_ValidEdit_ReturnsTrue()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);
            var opsi = new List<string> { "A", "B", "C", "D" };
            controller.TambahSoalManual("Pertanyaan awal", opsi, "A");

            var soal = controller.GetDaftarSoal().First();
            var editOpsi = new List<string> { "X", "Y", "Z", "A" };
            bool result = controller.EditSoalManual(soal.id, "Pertanyaan edit", editOpsi, "A");

            Assert.IsTrue(result);
            var updatedSoal = controller.GetDaftarSoal().First();
            Assert.AreEqual("Pertanyaan edit", updatedSoal.pertanyaan);
        }

        [TestMethod]
        public void EditSoalManual_InvalidJawaban_ReturnsFalse()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);
            var opsi = new List<string> { "A", "B", "C", "D" };
            controller.TambahSoalManual("Soal awal", opsi, "B");

            var soal = controller.GetDaftarSoal().First();
            var editOpsi = new List<string> { "A", "B", "C", "D" };
            bool result = controller.EditSoalManual(soal.id, "Soal edit", editOpsi, "Z");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HapusSoalManual_ShouldRemoveSoal()
        {
            var controller = new SoalController(SoalController.ModeSoal.Manual, false);
            var opsi = new List<string> { "A", "B", "C", "D" };
            controller.TambahSoalManual("Soal untuk dihapus", opsi, "D");

            var soal = controller.GetDaftarSoal().First();
            controller.HapusSoalManual(soal.id);

            Assert.AreEqual(0, controller.GetDaftarSoal().Count);
        }
    }
}
