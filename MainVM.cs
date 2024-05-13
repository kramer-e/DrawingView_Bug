using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Maui.Core;

namespace Drawingview_Bug
{
	public class MainVM
	{
		public ObservableCollection<IDrawingLine> DrawingLines { get; set; } = new();

        private ICommand _drawingCompletedCommand;

        public ICommand DrawingCompletedCommand
        {
            get
            {
                _drawingCompletedCommand ??= new Command(p => DrawingCompleted());
                return _drawingCompletedCommand;
            }
        }

        private void DrawingCompleted()
        {
            Application.Current?.MainPage?.DisplayAlert("Drawing completed", "binding works!", "OK");
        }
    }
}

