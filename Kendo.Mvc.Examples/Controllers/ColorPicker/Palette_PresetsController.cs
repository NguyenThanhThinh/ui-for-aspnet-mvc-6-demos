﻿using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
	public partial class ColorPickerController : Controller
	{
		public IActionResult Palette_Presets()
		{
			return View();
		}
	}
}
