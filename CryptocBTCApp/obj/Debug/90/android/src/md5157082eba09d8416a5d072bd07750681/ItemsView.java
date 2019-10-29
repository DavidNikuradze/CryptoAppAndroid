package md5157082eba09d8416a5d072bd07750681;


public class ItemsView
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CryptocBTCApp.ViewHolder.ItemsView, CryptocBTCApp", ItemsView.class, __md_methods);
	}


	public ItemsView (android.view.View p0)
	{
		super (p0);
		if (getClass () == ItemsView.class)
			mono.android.TypeManager.Activate ("CryptocBTCApp.ViewHolder.ItemsView, CryptocBTCApp", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
