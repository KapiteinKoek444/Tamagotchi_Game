package com.tamagotchi.bank.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.google.gson.Gson;
import com.tamagotchi.bank.model.Wallet;
import com.tamagotchi.bank.repository.WalletRepository;

@RestController
public class WalletController {
	
	@Autowired
	private WalletRepository repository;
	
	@GetMapping("/GetWallet/{id}")
	public Optional<Wallet> GetWallet(@PathVariable String id) {
		return repository.findById(id);
	}
	
	@PostMapping("/RemoveMoney/{id}/{amount}")
	public String RemoveMoney(@PathVariable String id, @PathVariable double amount) {
		Optional<Wallet> data = repository.findById(id);
		
		Wallet wallet = ConvertJson(data); 
		
		if((wallet.Balance - amount) < 0) {
			return "Failed, Insufficient balance";
		}else {
			wallet.Balance -= amount;
			repository.save(wallet);			
			return "Removed money!";
		}
		
	}
	
	@PostMapping("/AddMoney/{id}/{amount}")
	public String AddMoney(@PathVariable String id, @PathVariable double amount) {
		Optional<Wallet> data = repository.findById(id);
		Wallet wallet = ConvertJson(data);
		
		wallet.Balance += amount;
		repository.save(wallet);
		
		return "Succesfully added money";
	}
	
	@PostMapping("/AddWallet")
	public String AddWallet(@RequestBody Wallet wallet) {
		repository.save(wallet);
		return "Added wallet with id: " + wallet.getId();
	}
	
	@PostMapping("/UpdateWallet")
	public String UpdateWallet(@RequestBody Wallet wallet) {
		repository.save(wallet);
		return "Updated wallet with id: " + wallet.getId();		
	}
	
	private Wallet ConvertJson(Optional <Wallet> data) {
		Wallet wallet = new Gson().fromJson(data.toString(), Wallet.class);
		return wallet;
	}
}
