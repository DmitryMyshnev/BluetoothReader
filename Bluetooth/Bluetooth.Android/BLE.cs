using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(Bluetooth.Droid.BLE))]
namespace Bluetooth.Droid
{
     class BLE :IDeviceControl
    {
        public void  BluetoothManager()
        {
            BluetoothAdapter adapter = BluetoothAdapter.DefaultAdapter;
            if (adapter == null)
                throw new Exception("No Bluetooth adapter found.");

            if (!adapter.IsEnabled)
                // throw new Exception("Bluetooth adapter is not enabled.");
                adapter.Enable();
        }
    }
}