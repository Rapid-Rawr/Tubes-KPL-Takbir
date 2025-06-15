using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Controllers
{
    public class HasilController
    {
        private readonly string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hasilPengerjaan.json");
        private List<HasilPengerjaan> _hasilList;

        public HasilController()
        {
            _hasilList = JsonHelper.LoadFromFile<List<HasilPengerjaan>>(_path) ?? new List<HasilPengerjaan>();
        }

        public void SimpanHasil(string username, int totalSoal, int totalBenar)
        {
            int newId = _hasilList.Count > 0 ? _hasilList.Max(h => h.Id) + 1 : 1;

            var hasil = new HasilPengerjaan
            {
                Id = newId,
                Username = username,
                TotalSoal = totalSoal,
                TotalBenar = totalBenar
            };

            _hasilList.Add(hasil);
            JsonHelper.SaveToFile(_path, _hasilList);
        }

        public List<HasilPengerjaan> GetSemuaHasil()
        {
            return _hasilList;
        }
    }
}
