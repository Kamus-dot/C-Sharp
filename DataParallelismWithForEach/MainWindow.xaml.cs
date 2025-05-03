using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataParallelismWithForEach;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void cmdCancel_Click(object sender, EventArgs e)
    {

    }
    private void cmdProcess_Click(object sender, EventArgs e)
    {
        // Запустить новую "задачу" для обработки файлов.
        Task.Factory.StartNew(() => ProcessFiles());
        this.Title = "Processing Complete";
    }
    private void ProcessFiles()
    {
        var basePath = Directory.GetCurrentDirectory();
        var pictureDirectory = System.IO.Path.Combine(basePath, "TestPictures");
        var outputDirectory = System.IO.Path.Combine(basePath, "ModifiedPictures");
        if (Directory.Exists(outputDirectory))
        {
            Directory.Delete(outputDirectory, true);
        }
        Directory.CreateDirectory(outputDirectory);
        string[] files = Directory.GetFiles(pictureDirectory,
        "*.jpg", SearchOption.AllDirectories);
        Parallel.ForEach(files, currentFile =>
        {
            string filename = System.IO.Path.GetFileName(currentFile);
            // Этот оператор теперь приводит к проблеме!
            // this.Title = $"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}";
            Dispatcher?.Invoke(() =>
            {
                this.Title = $"Processing {filename}";
            });
            using (Bitmap bitmap = new Bitmap(currentFile))
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bitmap.Save(System.IO.Path.Combine(outputDirectory, filename));
            }
        });
    }
}