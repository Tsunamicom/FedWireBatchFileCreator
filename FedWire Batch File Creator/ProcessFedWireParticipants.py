import sys
sourcefolder = r'C:\Users\Tsunami\Documents\Visual Studio 2015'
subfolder = r'Projects\FedWire Batch File Creator\FedWire Batch File Creator\Properties\data'
file = r'fpddir.txt'
source = r'{0}\{1}\{2}'.format(sourcefolder, subfolder, file)
with open(source, 'r') as f:
    data = f.readlines()
    
quickdirectory = list()
directory = dict()
for line in data:
    aba = str(line[:9]).strip()
    shortname = str(line[9:27]).strip()
    fullname = str(line[27:63]).strip()
    directory[aba] = {'Number': aba, 'ShortName': shortname, 'FullName': fullname}
    quickdirectory.append(aba)

quickdirectory.sort()

    
