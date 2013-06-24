/* Lesson 4 - Trees and Traversals
 * Homework 3
 * 
 * Define classes File { string name, int size } and 
 * Folder { string name, File[] files, Folder[] childFolders }
 * and using them build a tree keeping all files and folders on 
 * the hard drive starting from C:\WINDOWS. Implement a method 
 * that calculates the sum of the file sizes in given subtree 
 * of the tree and test it accordingly. 
 * Use recursive DFS traversal.
 */

namespace FilesAndDirectoriesTree
{
    using System;

    public class Folder
    {
        public Folder(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("The name can not be null");
            }

            this.Name = name;
            this.Files = new File[0];
            this.ChildFolders = new Folder[0];
        }

        public Folder(string name, params File[] files)
            : this(name)
        {
            this.Files = files;
            this.ChildFolders = new Folder[0];
        }

        public Folder(string name, File[] files, Folder[] folders)
            : this(name, files)
        {
            this.ChildFolders = folders;
        }

        public string Name { get; set; }

        public File[] Files { get; set; }

        public Folder[] ChildFolders { get; set; }
    }
}