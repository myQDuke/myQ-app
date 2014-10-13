package xamarinstore;


public class XamarinSpinnerView
	extends android.view.View
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getRotation:()F:GetGetRotationHandler\n" +
			"n_setRotation:(F)V:GetSetRotation_FHandler\n" +
			"n_getScaleX:()F:GetGetScaleXHandler\n" +
			"n_setScaleX:(F)V:GetSetScaleX_FHandler\n" +
			"n_getScaleY:()F:GetGetScaleYHandler\n" +
			"n_setScaleY:(F)V:GetSetScaleY_FHandler\n" +
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinStore.XamarinSpinnerView, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", XamarinSpinnerView.class, __md_methods);
	}


	public XamarinSpinnerView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == XamarinSpinnerView.class)
			mono.android.TypeManager.Activate ("XamarinStore.XamarinSpinnerView, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public XamarinSpinnerView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == XamarinSpinnerView.class)
			mono.android.TypeManager.Activate ("XamarinStore.XamarinSpinnerView, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public XamarinSpinnerView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == XamarinSpinnerView.class)
			mono.android.TypeManager.Activate ("XamarinStore.XamarinSpinnerView, XamarinStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public float getRotation ()
	{
		return n_getRotation ();
	}

	private native float n_getRotation ();


	public void setRotation (float p0)
	{
		n_setRotation (p0);
	}

	private native void n_setRotation (float p0);


	public float getScaleX ()
	{
		return n_getScaleX ();
	}

	private native float n_getScaleX ();


	public void setScaleX (float p0)
	{
		n_setScaleX (p0);
	}

	private native void n_setScaleX (float p0);


	public float getScaleY ()
	{
		return n_getScaleY ();
	}

	private native float n_getScaleY ();


	public void setScaleY (float p0)
	{
		n_setScaleY (p0);
	}

	private native void n_setScaleY (float p0);


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);

	java.util.ArrayList refList;
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
