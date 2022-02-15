using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SetUp
{
    // A Test behaves as an ordinary method
    [Test]
    public void PawnMove()
    {
        var gameObject = new GameObject();
        var pawn = gameObject.GetComponent<Pawn>();
        var currentSpot = pawn.transform.position.z;

        Assert.AreEqual(currentSpot, pawn.transform.position.z);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void RookMove()
    {
        var gameObject = new GameObject();
        var rook = gameObject.GetComponent<Rook>();
        var currentSpot = rook.transform.position.z;

        Assert.AreEqual(currentSpot, rook.transform.position.z);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void KingMove()
    {
        var gameObject = new GameObject();
        var king = gameObject.GetComponent<King>();
        var currentSpot = king.transform.position.z;

        Assert.AreEqual(currentSpot, king.transform.position.z);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void QueenMove()
    {
        var gameObject = new GameObject();
        var queen = gameObject.GetComponent<Queen>();
        var currentSpot = queen.transform.position.z;

        Assert.AreEqual(currentSpot, queen.transform.position.z);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void KnightMove()
    {
        var gameObject = new GameObject();
        var knight = gameObject.GetComponent<Knight>();
        var currentSpot = knight.transform.position.z;

        Assert.AreEqual(currentSpot, knight.transform.position.z);
    }
}
