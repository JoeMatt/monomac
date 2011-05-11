#/bin/sh

SHARED_APIS="../../maccore/src/foundation.cs" # ../../maccore/src/coredata.cs ../../maccore/src/corelocation.cs ../../maccore/src/coreanimation.cs"

APIS="appkit.cs coreimage.cs foundation-desktop.cs growl.cs $SHARED_APIS" # corewlan.cs imagekit.cs qtkit.cs pdfkit.cs webkit.cs composer.cs

mono --debug ./bin/debug/MonoMac_bmac_.exe -a -d=MONOMAC --core --sourceonly=generated_source_list -v -tmpdir=. $APIS --baselib=./bin/debug/MonoMac_Core.dll --ns=MonoMac.ObjCRuntime -r=System.Drawing
