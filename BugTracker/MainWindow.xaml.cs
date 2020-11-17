using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BugTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        /** Goals for program
         *  - Add a bug to database 
         *  - Create description for bug
         *  - Add image / gif to show bug
         *  - Close bug
         *  - Record date of when bug was opened / closed
         */


    public partial class MainWindow : Window
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        public List<string> bugs = new List<string>();
        public List<Bug> bugSnax = new List<Bug>();
        public List<BugControls> bugControl = new List<BugControls>();
        public string imgPath;
        public string user;

        public MainWindow()
        {
            InitializeComponent();
            user = System.Environment.UserName;
        }

        //Once all fields are inputted
        //Bug is added
        private void AddBug_Click(object sender, RoutedEventArgs e)
        {
            if(nameOfBug.Text != "" && nameOfBug.Text != "Name")
            {
                bugs.Add(nameOfBug.Text);
                Bug newBug = new Bug();
                bugSnax.Add(newBug);
                newBug.bugDescription = descriptionBox.Text;
                newBug.bugName = nameOfBug.Text;
                newBug.isClosed = false;
                newBug.imageLocation = imgPath;
                newBug.reportedUser = user;
                //newBug.imageLocation 
                //bugSnax.Add
                updateBugs();
            }
            else
            {
                MessageBox.Show(nameOfBug.Text.ToString());
            }
        }
        private void viewBugs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yay");
        }


            public void updateBugs()
            {
            bugList.Document.Blocks.Clear();
            foreach (string bug in bugs)
            {
                //bugList.AppendText(bug);
            }
            foreach(Bug indBug in bugSnax)
            {
                bugList.AppendText(indBug.reportedUser);
                bugList.AppendText(indBug.bugName);
                bugList.AppendText(indBug.bugDescription);
                bugList.AppendText(indBug.imageLocation);
                //bugList.AppendText(indBug.imageLocation);
            }
            MessageBox.Show(bugSnax.Count.ToString());
        }

        private void ViewBugs_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            MessageBox.Show("Yay");
        }

        // This is the view bug tab
        private void viewBug_loaded(object sender, RoutedEventArgs e)
        {
            foreach(Bug indBug in bugSnax)
            {
                // This class is a container for all the UI elements 
                BugControls UIElements = new BugControls();
                // This adds the individual bug to the UI class
                UIElements.bugClass = indBug;
                // This toggle is whether or not the bug is closed
                Button toggleClosed = new Button();
                if(indBug.isClosed == true)
                {

                }
                // This is the label for the bug name
                Label nameOfBug = new Label();
                UIElements.nameLabel = nameOfBug;
                nameOfBug.Content = indBug.bugName;
                // This is label for who reported the bug
                Label userName = new Label();
                UIElements.userLabel = userName;
                userName.Content = indBug.reportedUser;
                // This is a textbox for a description of the bug
                RichTextBox bugDescription = new RichTextBox();
                UIElements.bugDescription = bugDescription;
                bugDescription.AppendText(indBug.bugDescription);
                // This is a image for a image / maybe GIF of the bug
                Image bugImg = new Image();
                UIElements.bugImage = bugImg;
                viewBugGrid.Children.Add(nameOfBug);
            }
        }

        public void displayBugs()
        {
            var yOffset = 25;
            foreach (BugControls bugControls in bugControl)
            {
                viewBugGrid.Children.Add(bugControls.bugDescription);

                yOffset += 25;
            }
        }

        // Opens file dialog to find image
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (fileDialog.ShowDialog() == true)
            {
                imgPath = fileDialog.FileName;
            }
            else
            {
                imgPath = null;
            }
        }
    }

    public class Bug
    {
        public string bugName { get; set; }
        public string bugDescription { get; set; }
        public string imageLocation { get; set; }
        public string reportedUser { get; set; }
        public bool isClosed { get; set; }
    }

    public class BugControls
    {
        public Bug bugClass { get; set; }
        public Label nameLabel { get; set; }
        public Label userLabel { get; set; }
        public RichTextBox bugDescription { get; set; }
        public Image bugImage { get; set; }
    }
}
