using System;
using System.Collections.Generic;
using System.Text;
using IRB.Revigo.Databases;

namespace GenerateSpeciesAnnotations
{
	class Program
	{
		static void Main(string[] args)
		{
			// which organisms to process
			int[] aTaxonIDs = new int[] {
				0,	// whole UniProt (default)
				// new Mar 2017 - change of TaxIDs to match the UniProt ones in "goa_uniprot_gcrp.gaf.gz"  (note 'gcrp') file
				3055,	// Chlamydomonas reinhardtii
				3702,	// Arabidopsis thaliana
				3827,	// Cicer arietinum - added 2021_07_27
				4081,	// Solanum lycopersicum	- added 2021_07_23
				4577,	// Zea mays
				6239,	// Caenorhabditis elegans
				7227,	// Drosophila melanogaster
				7955,	// Danio rerio
				8364,	// Xenopus tropicalis
				9031,	// Gallus gallus
				9606,	// Homo sapiens
				9913,	// Bos taurus
				10090,	// Mus musculus
				10116,	// Rattus norvegicus
				31033,	// Takifugu rubripes
				36329,	// Plasmodium falciparum
				39947,	// Oryza sativa
				44689,	// Dictyostelium discoideum
				83332,	// Mycobacterium tuberculosis
				83333,	// Escherichia coli
				//190650,	// Caulobacter crescentus
				208964,	// Pseudomonas aeruginosa
				224308,	// Bacillus subtilis
				//243273,	// Mycoplasma genitalium
				//272634,	// Mycoplasma pneumoniae
				284812,	// Schizosaccharomyces pombe
				559292,	// Saccharomyces cerevisiae
				946362, // Salpingoeca rosetta
				1111708,	// Synechocystis sp.
				//1413510	// Mycoplasma pneumoniae
			};

			SpeciesAnnotationsList annotations = SpeciesAnnotationsList.FromGOA(
				@"c:\Users\rajko\Documents\Projects\Revigo\Databases\EBI_GOA\2022_09_16\goa_uniprot_gcrp.gaf",
				@"c:\Users\rajko\Documents\Projects\Revigo\Databases\GeneOntology\2022_11_03\go.obo",
				@"c:\Users\rajko\Documents\Projects\Revigo\Databases\Taxonomy_NCBI\2022_11_18\names.dmp",
				aTaxonIDs);

			// serialize GOTermSizes object
			annotations.Serialize(@"c:\Users\rajko\Documents\Projects\Revigo\Databases\SpeciesAnnotations.xml", false);

			Console.WriteLine("Finished, press Enter key");
			Console.ReadLine();
		}
	}
}
