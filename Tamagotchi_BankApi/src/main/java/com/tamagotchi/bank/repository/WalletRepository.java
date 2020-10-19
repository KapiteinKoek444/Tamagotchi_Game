package com.tamagotchi.bank.repository;

import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

import com.tamagotchi.bank.model.Wallet;

@Repository
public interface WalletRepository extends MongoRepository<Wallet, String> {

}
