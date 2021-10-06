using apsEdao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static apsEdao.Models.Calculadora;

namespace apsEdao.Controllers
{
    public class CalculadoraController : Controller
    {

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<ApiResponse<CalculadoraResponse>>> CalculadoraRequest([FromBody] float valorA, [FromBody] float valorB)
        {
            try
            {
                var calculadora = new Calculadora() {
                    valor1 = valorA,
                    valor2 = valorB
                };

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // GET: CalculadoraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculadoraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
