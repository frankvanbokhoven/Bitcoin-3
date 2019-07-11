# Bitcoin3.Altcoins

Currently supported altcoins are:

* BCash
* BGold
* BitCore
* Dash
* Dogecoin
* Dystem
* Feathercoin
* Groestlcoin
* Liquid
* Litecoin
* Monacoin
* Polis
* UFO
* Viacoin
* Zclassic
* Koto
* Bitcoinplus
* Chaincoin

## How to use?

This package expose altcoin's `Network` class.
For example if you want to use Litecoin testnet:

```
Network network = Bitcoin3.Altcoins.Litecoin.Instance.Testnet;
```

You can then use this fork generating a Litecoin address for example:

```
Console.WriteLine(new Key().PubKey.GetAddress(network));
```

## How to support my own altcoin?

Follow Litecoin example and make a pull request.

Bitcoin3 developers do not test those PRs, so you are responsible to keep it working.

## How to test?

If you want to test your newly created `Network`, update [WellknownNodeDownloadData](../Bitcoin3.Tests/WellknownNodeDownloadData.cs) so the test environment can download binaries and run for your blockchain on regtest.

Then, change [NodeBuilderEx](../Bitcoin3.Tests/NodeBuilderEx.cs) like the following example.

```
public static NodeBuilder Create([CallerMemberName] string caller = null)
{
	return NodeBuilder.Create(NodeDownloadData.Litecoin.v0_15_1, Altcoins.AltNetworkSets.Litecoin.Regtest, caller);
}
```

You can then run the tests for your altcoin in command line from the Bitcoin3.Tests project:

Note that the first time can take a while because the test environment download the node binaries.

```
dotnet test Bitcoin3.Tests.csproj --filter "Altcoins=Altcoins" -p:ParallelizeTestCollections=false --framework netcoreapp2.1
```

You can also manually execute any test with Visual Studio.

Note that the tests with the trait `Altcoins=Altcoins` are only doing some sanity check. You might want to run additional tests.

You can take a look at [this commit as an example](https://github.com/frankvanbokhoven/Bitcoin3/commit/e075d1549ddd356f112cb3322c240490382c757e).
