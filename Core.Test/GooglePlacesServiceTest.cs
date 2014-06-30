﻿using System;
using NUnit.Framework;
using NuGet;
using Xamarin.Forms.Labs.Services.Geolocation;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core.Test
{
	[TestFixture]
	public class GooglePlacesServiceTest
	{
		[Test]
		public async void GetOpenWeatherForecast_ShouldReturnTheWeatherForecast ()
		{
			var googlePlacesService = new GooglePlacesService (new System.Net.Http.HttpClient ());

			var location = new Position {
				Latitude = 41.890969, Longitude = -87.676392 
			};

			var resultTask = googlePlacesService.GetCarWashesAsync (location);
			resultTask.Wait ();

			var places = resultTask.Result as List<Place>;

			Assert.IsNotNull (places);
		}
	}
}

