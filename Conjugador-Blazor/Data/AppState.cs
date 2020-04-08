using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace Conjugador_Blazor.Data
{
    public class AppState
    {
        public CultureInfo currentCulture { get; private set; } = CultureInfo.CurrentCulture;
        public event Action OnChange;
        public void ChangeCulture(CultureInfo newCulture)
        {
            currentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture.ClearCachedData();
            System.Threading.Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;
            NotifyStateChanged();
        }

        public CultureInfo getCurrentCulture()
        {
            if (currentCulture == null)
            {
                ChangeCulture(CultureInfo.CurrentCulture);
            }
            return currentCulture;

        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
