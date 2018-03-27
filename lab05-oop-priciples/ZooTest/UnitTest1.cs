using System;
using Xunit;
using lab05_oop_priciples;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void TheCount()
        {
            Vampire dracula = new Vampire("Vlad");
            Assert.Equal("Blood", dracula.Sustenance());
            Assert.True(dracula.Base == "human");
            Assert.False(dracula.Exists);
        }

        [Fact]
        public void Smaug()
        {
            Dragon smaug = new Dragon();
            Assert.Equal( 1, smaug.Heads);
            Assert.Equal("Fly", smaug.Locomotion());
            Assert.False(smaug.Exists);
        }

        [Fact]
        public void TreeBeard()
        {
            Ent treebeard = new Ent();
            Assert.Equal("Sunlight", treebeard.Sustenance());
            Assert.Equal("Lord of the Rings: The Two Towers (1954) by J.R.R. Tolkien", treebeard.Source());
        }

        [Fact]
        public void Fluffy()
        {
            Cerberus fluffy = new Cerberus();
            Assert.Equal(3, fluffy.Heads);
            Assert.Equal("Run", fluffy.Locomotion());
            Assert.False(fluffy.Exists);
        }
    }
}
