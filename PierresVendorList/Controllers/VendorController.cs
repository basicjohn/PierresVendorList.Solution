using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendorList.Models;

namespace PierresVendorList.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/Vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/Vendors")]
    public ActionResult Create(string VendorName, string description)
    {
      Vendor newVendor = new Vendor(VendorName, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/Vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> VendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", VendorOrders);
      return View(model);
    }
  }
}
