;InnoSetupVersion=5.5.0

[Setup]
AppName=SVPLC
AppId={{0D7AEFCC-17F8-491A-AA32-F9747DC3C440}
AppVersion=8.1.5
AppPublisher=Kiki's Company
DefaultDirName={pf}\SVPLC
DefaultGroupName=SVPLC
UninstallDisplayIcon={app}\Icone svplcall.ico
OutputBaseFilename=SVPLC
Compression=lzma
ChangesAssociations=yes
AllowNoIcons=yes
InfoBeforeFile=embedded\InfoBefore.txt
WizardImageFile=embedded\WizardImage0.bmp
WizardSmallImageFile=embedded\WizardSmallImage0.bmp

[Files]
Source: "{app}\SVPLC.exe"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Base de données associations.txt"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Base de données calendrier.txt"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Base de données rotations.txt"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Abricotier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Absinthe.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Ail.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Aneth.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Arbres Fruitiers.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Arroche.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Artichaut.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Asperge.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Aubergine.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Autres Choux.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Autres Pois.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Basilic.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Bette à carde.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Betterave.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Bourrache.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Brocoli.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Calendula.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Camomille.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Capucine.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Carotte.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Cerfeuil.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Cerise.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chardon.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chicorée.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou chinois Tatsoi.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou de Bruxelles.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou de Chine.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou pommé.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou Rouge.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou-Fleur.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou-Rave.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Chou.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Choux de Bruxelles.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Choux non Pommés.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Choux.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Ciboulette.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Citrouille.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Concombre.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Coriandre.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Cornichon.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Cosmos.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Courge.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Courgette.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Cresson.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Céleri.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Echalotte.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Epicéa.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Epinard.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Erable.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Euphorbe.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Fenouil.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Fougère.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Fraise.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Fraisier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Framboisier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Fève.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Genêt.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Giroflée.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Groseillier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Géranium.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Haricot nain.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Haricot rame.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Haricot.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Houx.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Hysope.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Laitue.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Lavande.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Maïs.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Melon.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Menthe.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Molène.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Myosotis.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Mâche.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Navet.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Oeillet d'Inde.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Oignon.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Origan.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Orme.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Ortie.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Panais.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Persil.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Phacélie.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Piment.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pin.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pissenlit.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Poireau.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Poirier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pois.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Poivron.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pomme de terre.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pommier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Potiron.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Pêcher.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Radis noir.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Radis.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Raifort.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Rhubarbe.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Romarin.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Rosier.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Rue.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Salade.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Salsifis.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Sarrasin.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Sarriette.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Sauge.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Souci.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Sureau.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Tanaisie.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Thym.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Tomate.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Topinambour.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Tournesol.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Valériane.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Fiches légumes\Vigne.txt"; DestDir: "{userdocs}\SVPLC\Fiches légumes"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Favoris.txt"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\grass.cur"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Icone svplcall.ico"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Icone svplcallfich.ico"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Liste légumes.txt"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{app}\Pellecurseur.cur"; DestDir: "{app}"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{userdocs}\SVPLC\Help_SVPLC.chm"; DestDir: "{userdocs}\SVPLC"; MinVersion: 0.0,5.0; Flags: ignoreversion 
Source: "{fonts}\Cooper Black.ttf"; DestDir: "{fonts}"; MinVersion: 0.0,5.0; Flags: uninsneveruninstall onlyifdoesntexist 
Source: "{fonts}\Wide Latin.ttf"; DestDir: "{fonts}"; MinVersion: 0.0,5.0; Flags: uninsneveruninstall onlyifdoesntexist 

[Registry]
Root: HKCR; Subkey: ".svplc"; ValueType: String; ValueData: "SauvegardeSVPLC"; MinVersion: 0.0,5.0; Flags: uninsdeletevalue 
Root: HKCR; Subkey: "SauvegardeSVPLC"; ValueType: String; ValueData: "Sauvegarde SVPLC"; MinVersion: 0.0,5.0; Flags: uninsdeletekey 
Root: HKCR; Subkey: "SauvegardeSVPLC\DefaultIcon"; ValueType: String; ValueData: "{app}\Icone svplcallfich.ico"; MinVersion: 0.0,5.0; 

[Run]
Filename: "{app}\SVPLC.exe"; Description: "{cm:LaunchProgram,SVPLC}"; MinVersion: 0.0,5.0; Flags: postinstall skipifsilent nowait

[Icons]
Name: "{group}\SVPLC"; Filename: "{app}\SVPLC.exe"; IconFilename: "{app}\Icone svplcall.ico"; MinVersion: 0.0,5.0; 
Name: "{commondesktop}\SVPLC"; Filename: "{app}\SVPLC.exe"; IconFilename: "{app}\Icone svplcall.ico"; Tasks: desktopicon; MinVersion: 0.0,5.0; 
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\SVPLC"; Filename: "{app}\SVPLC.exe"; IconFilename: "{app}\Icone svplcall.ico"; Tasks: quicklaunchicon; MinVersion: 0.0,5.0; 

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; MinVersion: 0.0,5.0; 
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; MinVersion: 0.0,5.0; OnlyBelowVersion: 0.0,6.01; 

[CustomMessages]
french.NameAndVersion=%1 version %2
french.AdditionalIcons=Icônes supplémentaires :
french.CreateDesktopIcon=Créer une icône sur le &Bureau
french.CreateQuickLaunchIcon=Créer une icône dans la barre de &Lancement rapide
french.ProgramOnTheWeb=Page d'accueil de %1
french.UninstallProgram=Désinstaller %1
french.LaunchProgram=Exécuter %1
french.AssocFileExtension=&Associer %1 avec l'extension de fichier %2
french.AssocingFileExtension=Associe %1 avec l'extension de fichier %2...
french.AutoStartProgramGroupDescription=Démarrage :
french.AutoStartProgram=Démarrer automatiquement %1
french.AddonHostProgramNotFound=%1 n'a pas été trouvé dans le dossier que vous avez choisi.%n%nVoulez-vous continuer malgré tout ?

[Languages]
; These files are stubs
; To achieve better results after recompilation, use the real language files
Name: "french"; MessagesFile: "embedded\french.isl"; 
