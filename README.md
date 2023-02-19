## Repository description
<p>This is the command line utility that generates REVIGO main databases used to process data. 
The utility is computationaly intensive and threaded (parallelized). Be careful when you specify number of cores your CPU has.</p>
<p>Since a lot of changes had to be made for .NET Core. Official release with binaries is planned for mid February 2023</p>

## How to compile and run
<p>You need to obtain the following files to generate REVIGO databases:
<ul>
	<li>EBI GOA database, <a href="ftp://ftp.ebi.ac.uk/pub/databases/GO/goa/UNIPROT/goa_uniprot_gcrp.gaf.gz">ftp://ftp.ebi.ac.uk/pub/databases/GO/goa/UNIPROT/goa_uniprot_gcrp.gaf.gz</a> (Needs to be uncompressed, be careful, uncompressed size exceeds 50GB),</li>
	<li>NCBI database, <a href="ftp://ftp.ncbi.nlm.nih.gov/pub/taxonomy/taxdump.tar.gz">ftp://ftp.ncbi.nlm.nih.gov/pub/taxonomy/taxdump.tar.gz</a> (Needs to be uncompressed),</li>
	<li>Gene Ontology database, <a href="http://purl.obolibrary.org/obo/go.obo">http://purl.obolibrary.org/obo/go.obo</a> and <a href="https://www.uniprot.org/docs/keywlist.txt">https://www.uniprot.org/docs/keywlist.txt</a> have to be in the same directory.</li>
</ul></p>
<p>Each directory containing a database also contains link.txt file containing a link to a database. For example EBI GOA link.txt file will contain the following: &quot;ftp://ftp.ebi.ac.uk/pub/databases/GO/goa/UNIPROT/goa_uniprot_gcrp.gaf.gz&quot;</p>
<p>After that adjust the paths in code to the database locations and you are ready to go.</p>
<p>To compile from command line: 
<ul>
	<li>Optional: Install <a href="https://visualstudio.microsoft.com/">Visual Studio Code</a> or <a href="https://visualstudio.microsoft.com/">Visual Studio for Windows</a> (You can also compile from Visual Studio for Windows)</li>
	<li>Install .NET core 6.0 from Microsoft (<a href="https://dotnet.microsoft.com/download">Install .NET for Windows</a>, <a href="https://learn.microsoft.com/en-us/dotnet/core/install/linux">Install .NET for Linux</a>)</li>
	<li>git clone https://github.com/rajko-horvat/RevigoGenerateDatabases</li>
	<li>dotnet build --configuration Release --os win-x64 RevigoGenerateDatabases.csproj (For Linux use --os linux. See <a href="https://learn.microsoft.com/en-us/dotnet/core/rid-catalog">list of OS RIDs</a> for --os option)</li>
	<li>Run generated binary file (under RevigoGenerateDatabases/bin/net6.0/) and enjoy.</li>
</ul></p>

## About REVIGO (REduce + VIsualize Gene Ontology) project
<p>Outcomes of high-throughput biological experiments are typically interpreted by statistical testing
for enriched gene functional categories defined by the Gene Ontology (GO). The resulting lists of GO terms 
may be large and highly redundant, and thus difficult to interpret.<p>
<p>REVIGO is a successful project to summarize long, unintelligible lists of Gene Ontology terms by finding a representative subset 
of the terms using a simple clustering algorithm that relies on semantic similarity measures.</p>
<p>For any further information about REVIGO project please see 
<a href="https://dx.doi.org/10.1371/journal.pone.0021800" target="_blank">published paper</a> and 
<a href="http://revigo.irb.hr/FAQ.aspx" target="_blank">Frequently Asked Questions page</a></p>
