
namespace FolderCrawling
{
	public class DirectoryTree
	{
		private string _data;
		private readonly DirectoryTree _parent;
		private readonly int _level;
		private readonly List<DirectoryTree> _children;

		public changeData(string _newData)
        {
			this._data = _newData;
        }

		public DirectoryTree(string data)
		{
			_data = data;
			_children = new List<DirectoryTree>();
			_level = 0;
		}

		public DirectoryTree(string data, DirectoryTree parent) : this(data)
		{
			_parent = parent;
			_level = _parent != null ? _parent.Level + 1 : 0;
		}

		public int Level { get { return _level; } }
		public int Count { get { return _children.Count; } }
		public bool IsRoot { get { return _parent == null; } }
		public bool IsLeaf { get { return _children.Count == 0; } }
		public string Data { get { return _data; } }
		public DirectoryTree Parent { get { return _parent; } }

		public DirectoryTree this[int key]
		{
			get { return _children[key]; }
		}

		public DirectoryTree AddChild(string value)
		{
			DirectoryTree node = new DirectoryTree(value, this);
			_children.Add(node);

			return node;
		}

		public bool HasChild(string data)
		{
			return FindInChildren(data) != null;
		}

		public DirectoryTree FindInChildren(string data)
		{
			int i = 0, l = Count;
			for (; i < l; ++i)
			{
				DirectoryTree child = _children[i];
				if (child.Data.Equals(data)) return child;
			}

			return null;
		}
	}
}