# Bitcoin3.Tests

You can group the unit tests per "Trait" in the Test Explorer.
Here are the trait Bitcoin3 is using :

* `Core` are tests I ported it directly from the bitcoind source, they have no dependency.
* `UnitTest` are self contained tests without dependency, but not ported from Bitcoin Core.
* `Protocol` are tests which check if Bitcoin3 correctly interpret P2P messaging with Bitcoin Core.
* `Altcoins` are tests meant to be used as test battery for altcoin integration. ([See more information](../Bitcoin3.Altcoins/README.md))
