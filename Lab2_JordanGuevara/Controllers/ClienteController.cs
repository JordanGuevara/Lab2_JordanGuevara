using Lab2_JordanGuevara.Models;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

public class ClienteController : Controller
{
    private FacturaContext db = new FacturaContext();

    // GET: Cliente
    public ActionResult Index()
    {
        var data = db.Clientes.Select(c => new ListClienteViewModel
        {
            id_cli = c.id_cli,
            nombre_cli = c.nombre_cli,
            cedula_cli = c.cedula_cli,
            correo_cli = c.correo_cli,
            fechaNacimiento_cli = c.fechaNacimiento_cli,
            FotoPath = c.FotoPath
        }).ToList();

        return View(data);
    }

    // GET: Cliente/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Cliente/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Cliente cliente, HttpPostedFileBase Foto)
    {
        if (ModelState.IsValid)
        {
            if (Foto != null && Foto.ContentLength > 0)
            {
                var fileName = Path.GetFileName(Foto.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                Foto.SaveAs(path);
                cliente.FotoPath = "/Images/" + fileName;
            }
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(cliente);
    }

    // GET: Cliente/Edit/5
    public ActionResult Edit(int id)
    {
        var cliente = db.Clientes.Find(id);
        if (cliente == null)
        {
            return HttpNotFound();
        }
        return View(cliente);
    }

    // POST: Cliente/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Cliente cliente, HttpPostedFileBase Foto)
    {
        if (ModelState.IsValid)
        {
            // Actualizar datos y guardar...
            db.Entry(cliente).State = EntityState.Modified;

            if (Foto != null && Foto.ContentLength > 0)
            {
                // Guardar la foto y actualizar FotoPath...
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(cliente);
    }

    // GET: Cliente/Delete/5
    public ActionResult Delete(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        var cli = db.Clientes.Find(id.Value);
        if (cli == null) return HttpNotFound();

        return View(cli);
    }


    // POST: Cliente/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
        var cli = db.Clientes.Find(id);
        db.Clientes.Remove(cli);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}
