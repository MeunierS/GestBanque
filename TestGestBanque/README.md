Tests à réaliser:

Personne:
	-ajout personne normal							OK !
	-nom null										OK !
	-prenom null									OK !
	-nom & prenom null								OK !

Banque:
	-ajout compte normal							OK !
	-ajout compte null								OK !
	-ajout compte deja existant						OK !
	-ajout banque normal							OK !
	-ajout banque null								OK !
	-supression compte existant						OK !
	-supression compte null							OK !
	-supression compte inexistant					OK !
	
Compte:
	-???
	
Courant:
	-depot positif									OK !
	-depot negatif									OK !
	-depot 0										OK !
	-retrait positif								OK !
	-retrait positif passe en negatif				OK !
	-retrait positif deja en negatif				OK !
	-retrait negatif								OK !
	-retrait 0										OK !
	-retrait positif depasse limite de credit		OK !

Epargne:
	-depot positif									OK !
	-depot negatif									OK !
	-depot 0										OK !
	-retrait positif								OK !
	-retrait positif passe en negatif				OK !
	-retrait negatif								OK !
	-retrait 0										OK !
