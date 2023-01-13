using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace PierresTreats.Controllers;

public class TreatsController : Controller
{
  private readonly PierresTreatsContext _db;

  public TreatsController(PierresTreatsContext db)
  {
    _db = db;
  }
  
  public ActionResult Index()
  {
    return View(_db.Treats.ToList());
  }

  // public ActionResult Create()
  // {
  //   return View();
  // }

  // [HttpPost]
  // public ActionResult Create(Engineer engineer)
  // {
  //   if (!ModelState.IsValid)
  //   {
  //     return View(engineer);
  //   }
  //   else
  //   {
  //     _db.Engineers.Add(engineer);
  //     _db.SaveChanges();
  //     return RedirectToAction("Index");
  //   }
  // }

  // public ActionResult Details(int id)
  // {
  //   ViewBag.Machines = _db.Machines.ToList();
  //   Engineer thisEngineer = _db.Engineers
  //     .Include(engineer => engineer.JoinEntities)
  //     .ThenInclude(join => join.Machine)
  //     .FirstOrDefault(engineer => engineer.EngineerId == id);
  //   return View(thisEngineer);
  // }

  // public ActionResult AddMachine(int id)
  // {
  //   Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
  //   ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
  //   return View(thisEngineer);
  // }

  // [HttpPost]
  // public ActionResult AddMachine(Engineer engineer, int machineId)
  // {
  //   #nullable enable
  //   EngineerMachine? joinEntity =_db.EngineerMachines.FirstOrDefault(join => (join.MachineId == machineId && join.EngineerId == engineer.EngineerId));
  //   #nullable disable
  //   if (joinEntity == null && machineId != 0)
  //   {
  //     _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
  //     _db.SaveChanges();
  //   }
  //   return RedirectToAction("Details", new { id = engineer.EngineerId});
  // }

  // public ActionResult Edit(int id)
  // {
  //   Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
  //   return View(thisEngineer);
  // }

  // [HttpPost]
  // public ActionResult Edit(Engineer engineer)
  // {
  //   if (!ModelState.IsValid)
  //   {
  //     return View(engineer);
  //   }
  //   else
  //   {
  //     _db.Entry(engineer).State = EntityState.Modified;
  //     _db.SaveChanges();
  //     return RedirectToAction("Details", new { id = engineer.EngineerId });
  //   }
  // }

  // public ActionResult Delete(int id)
  // {
  //   Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
  //   return View(thisEngineer);
  // }

  // [HttpPost, ActionName("Delete")]
  // public ActionResult DeleteConfirmed(int id)
  // {
  //   Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
  //   _db.Engineers.Remove(thisEngineer);
  //   _db.SaveChanges();
  //   return RedirectToAction("Index");
  // }

  // [HttpPost]
  // public ActionResult DeleteMachine(int joinId)
  // {
  //   EngineerMachine joinEntry = _db.EngineerMachines.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
  //   _db.EngineerMachines.Remove(joinEntry);
  //   _db.SaveChanges();
  //   return RedirectToAction("Details", new { id = joinEntry.EngineerId });
  // }
}