// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DrawerMadness {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("ParentWindow")]
	public partial class ParentWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("ParentWindowController")]
	public partial class ParentWindowController {
		
		private global::MonoMac.AppKit.NSDrawer __mt_leftDrawer;
		
		private global::MonoMac.AppKit.NSButton __mt_lowerRightAllowClose;
		
		private global::MonoMac.AppKit.NSWindow __mt_myParentWindow;
		
		private global::MonoMac.AppKit.NSButton __mt_upperRightAllowClose;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("closeBottomDrawer:")]
		partial void closeBottomDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("closeLeftDrawer:")]
		partial void closeLeftDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("closeLowerRightDrawer:")]
		partial void closeLowerRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("closeUpperRightDrawer:")]
		partial void closeUpperRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("openBottomDrawer:")]
		partial void openBottomDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("openLeftDrawer:")]
		partial void openLeftDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("openLowerRightDrawer:")]
		partial void openLowerRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("openUpperRightDrawer:")]
		partial void openUpperRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("toggleBottomDrawer:")]
		partial void toggleBottomDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("toggleLeftDrawer:")]
		partial void toggleLeftDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("toggleLowerRightDrawer:")]
		partial void toggleLowerRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Export("toggleUpperRightDrawer:")]
		partial void toggleUpperRightDrawer (MonoMac.AppKit.NSButtonCell sender);

		[MonoMac.Foundation.Connect("leftDrawer")]
		private global::MonoMac.AppKit.NSDrawer leftDrawer {
			get {
				this.__mt_leftDrawer = ((global::MonoMac.AppKit.NSDrawer)(this.GetNativeField("leftDrawer")));
				return this.__mt_leftDrawer;
			}
			set {
				this.__mt_leftDrawer = value;
				this.SetNativeField("leftDrawer", value);
			}
		}
		
		[MonoMac.Foundation.Connect("lowerRightAllowClose")]
		private global::MonoMac.AppKit.NSButton lowerRightAllowClose {
			get {
				this.__mt_lowerRightAllowClose = ((global::MonoMac.AppKit.NSButton)(this.GetNativeField("lowerRightAllowClose")));
				return this.__mt_lowerRightAllowClose;
			}
			set {
				this.__mt_lowerRightAllowClose = value;
				this.SetNativeField("lowerRightAllowClose", value);
			}
		}
		
		[MonoMac.Foundation.Connect("myParentWindow")]
		private global::MonoMac.AppKit.NSWindow myParentWindow {
			get {
				this.__mt_myParentWindow = ((global::MonoMac.AppKit.NSWindow)(this.GetNativeField("myParentWindow")));
				return this.__mt_myParentWindow;
			}
			set {
				this.__mt_myParentWindow = value;
				this.SetNativeField("myParentWindow", value);
			}
		}
		
		[MonoMac.Foundation.Connect("upperRightAllowClose")]
		private global::MonoMac.AppKit.NSButton upperRightAllowClose {
			get {
				this.__mt_upperRightAllowClose = ((global::MonoMac.AppKit.NSButton)(this.GetNativeField("upperRightAllowClose")));
				return this.__mt_upperRightAllowClose;
			}
			set {
				this.__mt_upperRightAllowClose = value;
				this.SetNativeField("upperRightAllowClose", value);
			}
		}
	}
}
