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
    public class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }

        public long Size { get; set; }
    }
}