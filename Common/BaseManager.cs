using System;

namespace ColorBall.Mod.Common
{
	public class BaseManager
	{
		public BaseManager()
		{
			InitData();
			InitEvents();
		}

		~BaseManager()
		{
			Release();
		}

		private void Release()
		{
			OnRelease();
		}
		private  void InitData()
		{
			OnInitData();
		}

		private  void InitEvents()
		{
			OnInitEvents();
		}

		public virtual void OnRelease()
		{ 

		}
		public virtual void OnInitData()
		{ 

		}
		public virtual void OnInitEvents()
		{ 

		}

		

	}
}
