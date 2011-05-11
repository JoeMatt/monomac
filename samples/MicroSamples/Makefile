DEMOS = \
	generate-pdf.exe	\
	locator.exe		\
	HelloCoreWlanSample.exe		

all: $(DEMOS)

run1:
	MONO_PATH=../../src/ mono generate-pdf.exe

generate-pdf.exe: generate-pdf.cs
	dmcs generate-pdf.cs -r:../../src/MonoMac.dll -r:System.Drawing

locator.exe: locator.cs
	dmcs locator.cs -r:../../src/MonoMac.dll 

HelloCoreWlanSample.exe: HelloCoreWlanSample.cs
	dmcs HelloCoreWlanSample.cs -r:../../src/MonoMac.dll
