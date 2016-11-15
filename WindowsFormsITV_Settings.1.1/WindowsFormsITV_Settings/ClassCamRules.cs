using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsITV_Settings
{
    class ClassCamRules
    {
	   public class TreeNode<T>
	   {
		  private string m_Name;
		  public string Name
		  {
			 get
			 {
				return this.m_Name;
			 }
			 set
			 {
				this.m_Name = value;
			 }
		  }

		  private T m_Data;
		  public T Data
		  {
			 get
			 {
				return this.m_Data;
			 }
			 set
			 {
				this.m_Data = value;
			 }
		  }

		  private LinkedList<TreeNode<T>> children;
		  public LinkedList<TreeNode<T>> Children
		  {
			 get
			 {
				return this.children;
			 }
		  }

		  public TreeNode()
		  {
			 this.children = new LinkedList<TreeNode<T>>();
		  }

		  public TreeNode(string name)
		  {
			 this.m_Name = name;
			 this.children = new LinkedList<TreeNode<T>>();
		  }

		  public TreeNode(T data, string name = "Value")
		  {
			 this.m_Name = name;
			 this.m_Data = data;
			 this.children = new LinkedList<TreeNode<T>>();
		  }

		  public void AddChild(TreeNode<T> node)
		  {
			 //node.Number = this.children.Count;
			 this.children.AddLast(node);
		  }

		  public void RemoveChild(TreeNode<T> node) 
		  {
			 this.children.Remove(node);
		  }
	   }
    }
}
