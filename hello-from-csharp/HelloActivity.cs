using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace hello_from_csharp
{
    [Activity(Label = "HelloActivity"),
        Register("hello_from_csharp.HelloActvity")]
    public class HelloActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.hello);
        }
    }
}