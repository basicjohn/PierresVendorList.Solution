using Microsoft.AspNetCore.Mvc;
using PierresVendorList.Models;
using System.Collections.Generic;

namespace PierresVendorList.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendor/{vendorId}/Order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/Order/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/vendor/{vendorId}/Order/{InvoiceNumber}")]
    public ActionResult Show(int vendorId, int InvoiceNumber)
    {
      Order order = Order.Find(InvoiceNumber);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}