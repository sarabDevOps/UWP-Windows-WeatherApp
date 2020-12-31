using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace weatherApp
{
    public  class LocationManager
    {


        //https://docs.microsoft.com/en-us/windows/uwp/maps-and-location/get-location

        public async static Task<Geoposition> getPosition() {

            var accessStatus = await Geolocator.RequestAccessAsync();

            if(accessStatus != GeolocationAccessStatus.Allowed)
            {
                throw new Exception();
                

            }
            //Give me whatever you can
            var geoLocator = new Geolocator { DesiredAccuracyInMeters = 0};

            var position = await geoLocator.GetGeopositionAsync();

            //return the position object 
            return position;

        }

    }
}
